// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class ListInstalledSoftwaresResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of installed software.</para>
        /// </summary>
        [NameInMap("AdditionalPackages")]
        [Validation(Required=false)]
        public ListInstalledSoftwaresResponseBodyAdditionalPackages AdditionalPackages { get; set; }
        public class ListInstalledSoftwaresResponseBodyAdditionalPackages : TeaModel {
            [NameInMap("AdditionalPackageInfos")]
            [Validation(Required=false)]
            public List<ListInstalledSoftwaresResponseBodyAdditionalPackagesAdditionalPackageInfos> AdditionalPackageInfos { get; set; }
            public class ListInstalledSoftwaresResponseBodyAdditionalPackagesAdditionalPackageInfos : TeaModel {
                /// <summary>
                /// <para>The category into which the software falls.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NWP</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The time when the software was installed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-03-05 18:24:08</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The software description.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The URL of the software icon.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://gw.alicdn.com/imgextra/i2/O1CN01FIkxZ81LmE0fvrAyR_!!6000000001341-55-tps-6349-1603.svg">https://gw.alicdn.com/imgextra/i2/O1CN01FIkxZ81LmE0fvrAyR_!!6000000001341-55-tps-6349-1603.svg</a></para>
                /// </summary>
                [NameInMap("Icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                /// <summary>
                /// <para>The software name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gromacs</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The installation status of the software.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Installed</description></item>
                /// <item><description>Uninstalled</description></item>
                /// <item><description>Installing</description></item>
                /// <item><description>Exception</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Installed</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The software version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024.1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
