// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class ModifyInstanceServiceConfigRequest : TeaModel {
        /// <summary>
        /// <para>The ID of target instance. You can call the <a href="https://help.aliyun.com/document_detail/144595.html">DescribeInstances</a> operation to obtain target instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hb-t4naqsay5gn****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;The name of the configuration item to modify. You can call the <a href="https://help.aliyun.com/document_detail/201980.html">ListInstanceServiceConfigurations</a> operation to query the configuration item name.
        /// &lt;props=&quot;intl&quot;&gt;The name of the configuration item to modify.</para>
        /// <remarks>
        /// <para>If you want to modify multiple configuration items, specify the Parameters parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hbase#hbase-site.xml#hbase.client.keyvalue.maxsize</para>
        /// </summary>
        [NameInMap("ConfigureName")]
        [Validation(Required=false)]
        public string ConfigureName { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;The value of the configuration item to modify. You can call the <a href="https://help.aliyun.com/document_detail/201980.html">ListInstanceServiceConfigurations</a> operation to query the configuration item value.
        /// &lt;props=&quot;intl&quot;&gt;The value of the configuration item to modify.</para>
        /// <remarks>
        /// <para>If you want to modify multiple configuration items, specify the Parameters parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10485770</para>
        /// </summary>
        [NameInMap("ConfigureValue")]
        [Validation(Required=false)]
        public string ConfigureValue { get; set; }

        /// <summary>
        /// <para>The JSON-formatted parameters for modifying multiple configuration items. The key specifies the name of the configuration item, and the value specifies the value of the configuration item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key1=value1&quot;, &quot;key2=value2&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        /// <summary>
        /// <para>Specifies whether to restart the instance after the configuration is modified. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Restart the instance.</description></item>
        /// <item><description><b>false</b>: Do not restart the instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Restart")]
        [Validation(Required=false)]
        public bool? Restart { get; set; }

    }

}
