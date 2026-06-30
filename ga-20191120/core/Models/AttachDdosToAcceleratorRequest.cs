// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class AttachDdosToAcceleratorRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Global Accelerator (GA) instance with which you want to associate the Anti-DDoS Pro or Anti-DDoS Premium instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga-bp1odcab8tmno0hdq****</para>
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// <para>The list of Anti-DDoS Pro or Anti-DDoS Premium instances to associate with the Global Accelerator (GA) instance.</para>
        /// </summary>
        [NameInMap("DdosConfigList")]
        [Validation(Required=false)]
        public List<AttachDdosToAcceleratorRequestDdosConfigList> DdosConfigList { get; set; }
        public class AttachDdosToAcceleratorRequestDdosConfigList : TeaModel {
            /// <summary>
            /// <para>The ID of the Anti-DDoS Pro or Anti-DDoS Premium instance to associate with the Global Accelerator (GA) instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ddoscoo-cn-zz11vq7j****</para>
            /// </summary>
            [NameInMap("DdosId")]
            [Validation(Required=false)]
            public string DdosId { get; set; }

            /// <summary>
            /// <para>The region of the Anti-DDoS Pro or Anti-DDoS Premium instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>cn-hangzhou</b>: the Chinese mainland.</para>
            /// </description></item>
            /// <item><description><para><b>ap-southeast-1</b>: outside the Chinese mainland.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("DdosRegionId")]
            [Validation(Required=false)]
            public string DdosRegionId { get; set; }

        }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The ID of the Anti-DDoS Pro or Anti-DDoS Premium instance to associate with the Global Accelerator (GA) instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddoscoo-cn-zz11vq7j****</para>
        /// </summary>
        [NameInMap("DdosId")]
        [Validation(Required=false)]
        [Obsolete]
        public string DdosId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The region of the Anti-DDoS Pro or Anti-DDoS Premium instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-hangzhou</b>: the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1</b>: outside the Chinese mainland.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DdosRegionId")]
        [Validation(Required=false)]
        [Obsolete]
        public string DdosRegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: performs a dry run without actually associating the instances. The system checks the required parameters, request syntax, and business limits. If the check fails, the corresponding error is returned. If the check passes, an HTTP 2xx status code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): sends the request. After the request passes the check, an HTTP 2xx status code is returned and the operation is performed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The region ID of the Global Accelerator (GA) instance. Set the value to <b>cn-hangzhou</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
