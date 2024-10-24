// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ConfigNetworkRegionBlockRequest : TeaModel {
        /// <summary>
        /// <para>The details of the configurations of blocked locations. This parameter is a JSON string. The value consists of the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>RegionBlockSwitch</b>: the status of the location blacklist feature. This field is required and must be of the string type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b></description></item>
        /// <item><description><b>off</b></description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>Countries</b>: the codes of the countries and areas from which you want to block requests. This field is optional and must be of the array type.</para>
        /// <para>**</para>
        /// <para><b>Note</b> For more information about the codes of countries and areas, see <a href="https://help.aliyun.com/document_detail/167926.html">Location parameters</a>.</para>
        /// </description></item>
        /// <item><description><para><b>Provinces</b>: the codes of the administrative regions in China from which you want to block requests. This field is optional and must be of the array type.</para>
        /// <para>**</para>
        /// <para><b>Note</b> For more information about the codes of administrative regions in China, see <a href="https://help.aliyun.com/document_detail/167926.html">Location parameters</a>.</para>
        /// <para>For example, <c>[11,12]</c> specifies Beijing and Tianjin.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;RegionBlockSwitch&quot;:&quot;off&quot;,&quot;Countries&quot;:[],&quot;Provinces&quot;:[11,12,13,14,15,21,22,23,31,32,33,34,35,36,37,41,42,43,44,45,46,50,51,52,53,54,61,62,63,64,65,71,81,82]}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/157459.html">DescribeInstanceIds</a> operation to query the IDs of all instances.</para>
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
