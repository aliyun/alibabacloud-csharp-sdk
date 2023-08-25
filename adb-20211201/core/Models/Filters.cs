// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class Filters : TeaModel {
        [NameInMap("AppIdRegex")]
        [Validation(Required=false)]
        public string AppIdRegex { get; set; }

        [NameInMap("AppNameRegex")]
        [Validation(Required=false)]
        public string AppNameRegex { get; set; }

        [NameInMap("AppState")]
        [Validation(Required=false)]
        public string AppState { get; set; }

        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        [NameInMap("ExecutionTimeRange")]
        [Validation(Required=false)]
        public FiltersExecutionTimeRange ExecutionTimeRange { get; set; }
        public class FiltersExecutionTimeRange : TeaModel {
            [NameInMap("MaxTimeInSeconds")]
            [Validation(Required=false)]
            public long? MaxTimeInSeconds { get; set; }

            [NameInMap("MinTimeInSeconds")]
            [Validation(Required=false)]
            public long? MinTimeInSeconds { get; set; }

        }

        [NameInMap("SubmitTimeRange")]
        [Validation(Required=false)]
        public FiltersSubmitTimeRange SubmitTimeRange { get; set; }
        public class FiltersSubmitTimeRange : TeaModel {
            [NameInMap("MaxTimeInMills")]
            [Validation(Required=false)]
            public long? MaxTimeInMills { get; set; }

            [NameInMap("MinTimeInMills")]
            [Validation(Required=false)]
            public long? MinTimeInMills { get; set; }

        }

        [NameInMap("TermiatedTimeRange")]
        [Validation(Required=false)]
        public FiltersTermiatedTimeRange TermiatedTimeRange { get; set; }
        public class FiltersTermiatedTimeRange : TeaModel {
            [NameInMap("MaxTimeInMills")]
            [Validation(Required=false)]
            public long? MaxTimeInMills { get; set; }

            [NameInMap("MinTimeInMills")]
            [Validation(Required=false)]
            public long? MinTimeInMills { get; set; }

        }

    }

}
