// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeAppsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeAppsResponseBodyData> Data { get; set; }
        public class DescribeAppsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("AndroidAppVersion")]
            [Validation(Required=false)]
            public string AndroidAppVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10404</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public int? AppId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testapp</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("BizRegionId")]
            [Validation(Required=false)]
            public string BizRegionId { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-08-11 17:45:03</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-08-11 17:45:03</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://test.png">https://test.png</a></para>
            /// </summary>
            [NameInMap("IconUrl")]
            [Validation(Required=false)]
            public string IconUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>INSTALLING</para>
            /// </summary>
            [NameInMap("InstallationStatus")]
            [Validation(Required=false)]
            public string InstallationStatus { get; set; }

            [NameInMap("InstanceGroupList")]
            [Validation(Required=false)]
            public List<string> InstanceGroupList { get; set; }

            [NameInMap("PackageName")]
            [Validation(Required=false)]
            public string PackageName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6l5V9uON****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CB95E410-FD1D-53C5-9F7D-93CC44D7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
