// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class ModifyDrdsIpWhiteListRequest : TeaModel {
        /// <summary>
        /// <para>The name of the DRDS database.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>The ID of the Message Queue for Apache Kafka instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>drds****c6vxxyzd</para>
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// <para>The attribute of the IP address whitelist group.</para>
        /// </summary>
        [NameInMap("GroupAttribute")]
        [Validation(Required=false)]
        public string GroupAttribute { get; set; }

        /// <summary>
        /// <para>The name of the IP address whitelist group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>drds_******</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The modified whitelist. Separate multiple IP addresses with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.<em><b>.</b></em>.<em><b>,10.</b></em>.<em><b>.</b></em></para>
        /// </summary>
        [NameInMap("IpWhiteList")]
        [Validation(Required=false)]
        public string IpWhiteList { get; set; }

        /// <summary>
        /// <para>Specifies the mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>True</c>: append modifications</description></item>
        /// <item><description><c>False</c>: overwrite modification</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public bool? Mode { get; set; }

    }

}
