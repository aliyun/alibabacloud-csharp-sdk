// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ModifyEnterpriseAcceleratePolicyRequest : TeaModel {
        /// <summary>
        /// <para>The acceleration mode:</para>
        /// <list type="bullet">
        /// <item><description><b>whiltelist</b>: whitelist acceleration</description></item>
        /// <item><description><b>global</b>: global acceleration</description></item>
        /// <item><description><b>build-in-list</b>: built-in system application acceleration</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>whitelist</para>
        /// </summary>
        [NameInMap("AccelerationType")]
        [Validation(Required=false)]
        public string AccelerationType { get; set; }

        /// <summary>
        /// <para>The description of the enterprise acceleration policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>这是一条内网访问策略</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the enterprise acceleration policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eap-ce153a7165c8feea</para>
        /// </summary>
        [NameInMap("EapId")]
        [Validation(Required=false)]
        public string EapId { get; set; }

        /// <summary>
        /// <para>The name of the enterprise acceleration policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>白名单策略001</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable TLS mode:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: disable</description></item>
        /// <item><description><b>1</b>: enable</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OnTls")]
        [Validation(Required=false)]
        public int? OnTls { get; set; }

        /// <summary>
        /// <para>The priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>49</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>Specifies whether to display on the client:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: do not display</description></item>
        /// <item><description><b>1</b>: display</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ShowInClient")]
        [Validation(Required=false)]
        public int? ShowInClient { get; set; }

        /// <summary>
        /// <para>The address (IP or domain name) of the acceleration instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12.34.56.XX</para>
        /// </summary>
        [NameInMap("UpstreamHost")]
        [Validation(Required=false)]
        public string UpstreamHost { get; set; }

        /// <summary>
        /// <para>The port of the acceleration instance (between 1000 and 60000).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("UpstreamPort")]
        [Validation(Required=false)]
        public int? UpstreamPort { get; set; }

        /// <summary>
        /// <para>The acceleration instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga</para>
        /// </summary>
        [NameInMap("UpstreamType")]
        [Validation(Required=false)]
        public string UpstreamType { get; set; }

        /// <summary>
        /// <para>The acceleration user group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试用户组</para>
        /// </summary>
        [NameInMap("UserAttributeGroup")]
        [Validation(Required=false)]
        public string UserAttributeGroup { get; set; }

    }

}
