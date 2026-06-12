# BookTrackerApp

This project was generated using [Angular CLI](https://github.com/angular/angular-cli) version 22.0.1.

## Development server

To start a local development server, run:

```bash
ng serve
```

Once the server is running, open your browser and navigate to `http://localhost:4200/`. The application will automatically reload whenever you modify any of the source files.

## Code scaffolding

Angular CLI includes powerful code scaffolding tools. To generate a new component, run:

```bash
ng generate component component-name
```

For a complete list of available schematics (such as `components`, `directives`, or `pipes`), run:

```bash
ng generate --help
```

## Building

To build the project run:

```bash
ng build
```

This will compile your project and store the build artifacts in the `dist/` directory. By default, the production build optimizes your application for performance and speed.

## Running unit tests

To execute unit tests with the [Vitest](https://vitest.dev/) test runner, use the following command:

```bash
ng test
```

## Running end-to-end tests

For end-to-end (e2e) testing, run:

```bash
ng e2e
```

Angular CLI does not come with an end-to-end testing framework by default. You can choose one that suits your needs.

## Additional Resources

For more information on using the Angular CLI, including detailed command references, visit the [Angular CLI Overview and Command Reference](https://angular.dev/tools/cli) page.

```
book-tracker-app
├─ .angular
│  └─ cache
│     └─ 22.0.1
│        └─ book-tracker-app
│           ├─ .tsbuildinfo
│           ├─ angular-compiler.db
│           ├─ angular-compiler.db-lock
│           └─ vite
│              ├─ deps
│              │  ├─ @angular_common.js
│              │  ├─ @angular_common.js.map
│              │  ├─ @angular_common_http.js
│              │  ├─ @angular_common_http.js.map
│              │  ├─ @angular_core.js
│              │  ├─ @angular_core.js.map
│              │  ├─ @angular_platform-browser.js
│              │  ├─ @angular_platform-browser.js.map
│              │  ├─ @angular_router.js
│              │  ├─ @angular_router.js.map
│              │  ├─ _metadata.json
│              │  ├─ chunk-2SWTHDVQ.js
│              │  ├─ chunk-2SWTHDVQ.js.map
│              │  ├─ chunk-E4DNV77X.js
│              │  ├─ chunk-E4DNV77X.js.map
│              │  ├─ chunk-EP4BPSD6.js
│              │  ├─ chunk-EP4BPSD6.js.map
│              │  ├─ chunk-I6JEUJ5L.js
│              │  ├─ chunk-I6JEUJ5L.js.map
│              │  ├─ chunk-S3JHLBJT.js
│              │  ├─ chunk-S3JHLBJT.js.map
│              │  └─ package.json
│              └─ deps_ssr
│                 ├─ @angular_common.js
│                 ├─ @angular_common.js.map
│                 ├─ @angular_common_http.js
│                 ├─ @angular_common_http.js.map
│                 ├─ @angular_core.js
│                 ├─ @angular_core.js.map
│                 ├─ @angular_platform-browser.js
│                 ├─ @angular_platform-browser.js.map
│                 ├─ @angular_platform-server_init.js
│                 ├─ @angular_platform-server_init.js.map
│                 ├─ @angular_router.js
│                 ├─ @angular_router.js.map
│                 ├─ @angular_ssr.js
│                 ├─ @angular_ssr.js.map
│                 ├─ @angular_ssr_node.js
│                 ├─ @angular_ssr_node.js.map
│                 ├─ _metadata.json
│                 ├─ chunk-6DU2HRTW.js
│                 ├─ chunk-6DU2HRTW.js.map
│                 ├─ chunk-7VO7PY3Q.js
│                 ├─ chunk-7VO7PY3Q.js.map
│                 ├─ chunk-B7RE2A5G.js
│                 ├─ chunk-B7RE2A5G.js.map
│                 ├─ chunk-CKKG5TI3.js
│                 ├─ chunk-CKKG5TI3.js.map
│                 ├─ chunk-HCWJTDCA.js
│                 ├─ chunk-HCWJTDCA.js.map
│                 ├─ chunk-I2WSEEOA.js
│                 ├─ chunk-I2WSEEOA.js.map
│                 ├─ chunk-IHZVPIBM.js
│                 ├─ chunk-IHZVPIBM.js.map
│                 ├─ chunk-TWPWCB6X.js
│                 ├─ chunk-TWPWCB6X.js.map
│                 ├─ chunk-WAMIVCBV.js
│                 ├─ chunk-WAMIVCBV.js.map
│                 ├─ express.js
│                 ├─ express.js.map
│                 ├─ package.json
│                 ├─ xhr2-E5RTESSH.js
│                 └─ xhr2-E5RTESSH.js.map
├─ .editorconfig
├─ .prettierrc
├─ README.md
├─ angular.json
├─ dist
│  └─ book-tracker-app
│     ├─ 3rdpartylicenses.txt
│     ├─ browser
│     │  ├─ favicon.ico
│     │  ├─ index.csr.html
│     │  ├─ index.html
│     │  ├─ main-2725UV3S.js
│     │  └─ styles-5INURTSO.css
│     ├─ prerendered-routes.json
│     └─ server
│        ├─ angular-app-engine-manifest.mjs
│        ├─ angular-app-manifest.mjs
│        ├─ assets-chunks
│        │  ├─ index_csr_html.mjs
│        │  ├─ index_html.mjs
│        │  ├─ index_server_html.mjs
│        │  └─ styles-5INURTSO_css.mjs
│        ├─ chunk-BBJ2OP3G.mjs
│        ├─ chunk-BP7AI3FB.mjs
│        ├─ chunk-N3SI5I4Q.mjs
│        ├─ chunk-T55IDOPT.mjs
│        ├─ index.server.html
│        ├─ main.server.mjs
│        ├─ polyfills.server.mjs
│        └─ server.mjs
├─ package-lock.json
├─ package.json
├─ public
│  └─ favicon.ico
├─ src
│  ├─ app
│  │  ├─ app.config.server.ts
│  │  ├─ app.config.ts
│  │  ├─ app.css
│  │  ├─ app.html
│  │  ├─ app.routes.server.ts
│  │  ├─ app.routes.ts
│  │  ├─ app.spec.ts
│  │  ├─ app.ts
│  │  ├─ books
│  │  │  ├─ book-info.css
│  │  │  ├─ book-info.html
│  │  │  └─ book-info.ts
│  │  ├─ buttons
│  │  │  └─ drop-down
│  │  │     ├─ drop-down.css
│  │  │     ├─ drop-down.html
│  │  │     └─ drop-down.ts
│  │  ├─ models
│  │  │  └─ book.ts
│  │  └─ services
│  │     ├─ book.spec.ts
│  │     └─ book.ts
│  ├─ index.html
│  ├─ main.server.ts
│  ├─ main.ts
│  ├─ server.ts
│  └─ styles.css
├─ tsconfig.app.json
├─ tsconfig.json
└─ tsconfig.spec.json

```