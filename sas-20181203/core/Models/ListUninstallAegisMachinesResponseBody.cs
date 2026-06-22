// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListUninstallAegisMachinesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the current page in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The list of server information.</para>
        /// </summary>
        [NameInMap("MachineList")]
        [Validation(Required=false)]
        public List<ListUninstallAegisMachinesResponseBodyMachineList> MachineList { get; set; }
        public class ListUninstallAegisMachinesResponseBodyMachineList : TeaModel {
            /// <summary>
            /// <para>The ID of the server instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sas-bdrvxb4b****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the server instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sql-test-001</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120.79.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The region where the server resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("MachineRegion")]
            [Validation(Required=false)]
            public string MachineRegion { get; set; }

            /// <summary>
            /// <para>The operating system of the server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>linux</b>: linux</para>
            /// </description></item>
            /// <item><description><para><b>windows</b>: windows</para>
            /// </description></item>
            /// <item><description><para><b>windows-2003</b>: windows-2003.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>linux</para>
            /// </summary>
            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            /// <summary>
            /// <para>The ID of the region where the server resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The UUID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6d5b361f-958d-48a8-a9d2-d6e82c1****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            /// <summary>
            /// <para>The server vendor. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Alibaba Cloud asset</description></item>
            /// <item><description><b>1</b>: non-cloud asset</description></item>
            /// <item><description><b>2</b>: IDC asset</description></item>
            /// <item><description><b>3</b>, <b>4</b>, <b>5</b>, <b>7</b>: third-party cloud asset</description></item>
            /// <item><description><b>8</b>: lightweight asset.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public int? Vendor { get; set; }

            /// <summary>
            /// <para>The name of the server vendor.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ALIYUN</b>: Alibaba Cloud</description></item>
            /// <item><description><b>OUT</b>: non-cloud asset</description></item>
            /// <item><description><b>IDC</b>: IDC</description></item>
            /// <item><description><b>TENCENT</b>: third-party cloud</description></item>
            /// <item><description><b>HUAWEICLOUD</b>: third-party cloud</description></item>
            /// <item><description><b>Microsoft</b>: third-party cloud</description></item>
            /// <item><description><b>AWS</b>: third-party cloud</description></item>
            /// <item><description><b>TRIPARTITE</b>: lightweight server.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN</para>
            /// </summary>
            [NameInMap("VendorName")]
            [Validation(Required=false)]
            public string VendorName { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries per page in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>151F6EB6-D5F3-417A-AF7B-4D84975DB586</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>44</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
