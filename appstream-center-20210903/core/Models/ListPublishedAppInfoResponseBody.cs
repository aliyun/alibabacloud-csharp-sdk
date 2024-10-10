// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210903.Models
{
    public class ListPublishedAppInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>appModels</para>
        /// </summary>
        [NameInMap("AppModels")]
        [Validation(Required=false)]
        public List<ListPublishedAppInfoResponseBodyAppModels> AppModels { get; set; }
        public class ListPublishedAppInfoResponseBodyAppModels : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>img-f37nddbjc1lje14st</para>
            /// </summary>
            [NameInMap("AppCenterImageId")]
            [Validation(Required=false)]
            public string AppCenterImageId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ca-fxwp4koyr5y2sp4mz</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Microsoft Word</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("AppThemeColor")]
            [Validation(Required=false)]
            public string AppThemeColor { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>R2021a</para>
            /// </summary>
            [NameInMap("AppVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>v1.0</para>
            /// </summary>
            [NameInMap("AppVersionName")]
            [Validation(Required=false)]
            public string AppVersionName { get; set; }

            [NameInMap("AuthTime")]
            [Validation(Required=false)]
            public string AuthTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public long? CategoryId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CategoryType")]
            [Validation(Required=false)]
            public long? CategoryType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://app-streaming-icon-prod-shanghai.oss-cn-shanghai.aliyuncs.com/tenant/1973619010349344/1634523814270_Matlab.png">https://app-streaming-icon-prod-shanghai.oss-cn-shanghai.aliyuncs.com/tenant/1973619010349344/1634523814270_Matlab.png</a></para>
            /// </summary>
            [NameInMap("IconUrl")]
            [Validation(Required=false)]
            public string IconUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("IsAuth")]
            [Validation(Required=false)]
            public bool? IsAuth { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("UsedInSession")]
            [Validation(Required=false)]
            public bool? UsedInSession { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2NVfhLfgy5b3J5iJyoLQ6x4EULMg1hbhgB9NfnvdK9oj5zwxd17j4TuQkZze3RvhEvBinZYjknujF3Q1M</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>DB70F8FE-63A3-587B-8560-CEC258E8B944</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
