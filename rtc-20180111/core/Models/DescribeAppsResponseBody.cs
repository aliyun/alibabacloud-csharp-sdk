// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeAppsResponseBody : TeaModel {
        [NameInMap("AppList")]
        [Validation(Required=false)]
        public DescribeAppsResponseBodyAppList AppList { get; set; }
        public class DescribeAppsResponseBodyAppList : TeaModel {
            [NameInMap("App")]
            [Validation(Required=false)]
            public List<DescribeAppsResponseBodyAppListApp> App { get; set; }
            public class DescribeAppsResponseBodyAppListApp : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>rgf1****&quot;</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Default AppName</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>universal</para>
                /// </summary>
                [NameInMap("AppType")]
                [Validation(Required=false)]
                public string AppType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>paybyduration</para>
                /// </summary>
                [NameInMap("BillType")]
                [Validation(Required=false)]
                public string BillType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-01-09T02:02:29Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("ServiceAreas")]
                [Validation(Required=false)]
                public DescribeAppsResponseBodyAppListAppServiceAreas ServiceAreas { get; set; }
                public class DescribeAppsResponseBodyAppListAppServiceAreas : TeaModel {
                    [NameInMap("ServiceArea")]
                    [Validation(Required=false)]
                    public List<string> ServiceArea { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6159ba01-6687-4fb2-a831-f0cd8d188648</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
