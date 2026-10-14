// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ConfigNetworkRegionBlockRequest : TeaModel {
        /// <summary>
        /// <para>The configuration of the location blacklist, expressed as a JSON string with the following structure:</para>
        /// <list type="bullet">
        /// <item><description><para><b>RegionBlockSwitch</b>: String type. Required. The switch status of the location blacklist. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: enabled</description></item>
        /// <item><description><b>off</b>: disabled</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>Countries</b>: Array type. Optional. The list of international region codes to block.</para>
        /// <remarks>
        /// <para>For more information about international region codes, see <a href="https://help.aliyun.com/document_detail/167926.html">Parameters for China and international regions</a>.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para><b>Provinces</b>: Array type. Optional. The list of China region codes to block.</para>
        /// <remarks>
        /// <para>For more information about China region codes, see <a href="https://help.aliyun.com/document_detail/167926.html">Parameters for China and international regions</a>.</para>
        /// </remarks>
        /// <para>  For example, <c>[11,12]</c> indicates Beijing and Tianjin.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;RegionBlockSwitch&quot;:&quot;on&quot;,&quot;Countries&quot;:[],&quot;Provinces&quot;:[11,12,13,14,15,21,22,23,31,32,33,34,35,36,37,41,42,43,44,45,46,50,51,52,53,54,61,62,63,64,65,71,81,82]}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The ID of the Anti-DDoS Pro or Anti-DDoS Premium instance.</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/157459.html">DescribeInstanceIds</a> to query the IDs of all Anti-DDoS Pro or Anti-DDoS Premium instances.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddoscoo-cn-mp91j1ao****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
