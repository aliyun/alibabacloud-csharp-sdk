// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210903.Models
{
    public class ListPublishedAppInfoResponseBody : TeaModel {
        /// <summary>
        /// appModels
        /// </summary>
        [NameInMap("AppModels")]
        [Validation(Required=false)]
        public List<ListPublishedAppInfoResponseBodyAppModels> AppModels { get; set; }
        public class ListPublishedAppInfoResponseBodyAppModels : TeaModel {
            [NameInMap("AppCenterImageId")]
            [Validation(Required=false)]
            public string AppCenterImageId { get; set; }

            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("AppThemeColor")]
            [Validation(Required=false)]
            public string AppThemeColor { get; set; }

            [NameInMap("AppVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            [NameInMap("AppVersionName")]
            [Validation(Required=false)]
            public string AppVersionName { get; set; }

            [NameInMap("AuthTime")]
            [Validation(Required=false)]
            public string AuthTime { get; set; }

            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public long? CategoryId { get; set; }

            [NameInMap("CategoryType")]
            [Validation(Required=false)]
            public long? CategoryType { get; set; }

            [NameInMap("IconUrl")]
            [Validation(Required=false)]
            public string IconUrl { get; set; }

            [NameInMap("IsAuth")]
            [Validation(Required=false)]
            public bool? IsAuth { get; set; }

            [NameInMap("UsedInSession")]
            [Validation(Required=false)]
            public bool? UsedInSession { get; set; }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
