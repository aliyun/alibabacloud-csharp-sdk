// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeEdgeMachineActiveProcessResponseBody : TeaModel {
        /// <summary>
        /// <para>The activation progress list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;content&quot;:&quot;步骤 &quot;颁发激活凭证&quot; 执行开始&quot;,&quot;id&quot;:0,&quot;level&quot;:3,&quot;timestamp&quot;:1625994913000},{&quot;content&quot;:&quot;步骤 &quot;颁发激活凭证&quot; 执行成功&quot;,&quot;id&quot;:1,&quot;level&quot;:3,&quot;timestamp&quot;:1625994914000},{&quot;content&quot;:&quot;步骤 &quot;初始化主机配置&quot; 执行开始&quot;,&quot;id&quot;:2,&quot;level&quot;:3,&quot;timestamp&quot;:1625994975000},{&quot;content&quot;:&quot;步骤 &quot;初始化主机配置&quot; 执行成功&quot;,&quot;id&quot;:3,&quot;level&quot;:3,&quot;timestamp&quot;:1625994975000}]</para>
        /// </summary>
        [NameInMap("logs")]
        [Validation(Required=false)]
        public string Logs { get; set; }

        /// <summary>
        /// <para>The activation progress.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("progress")]
        [Validation(Required=false)]
        public long? Progress { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b62796a8-c5a6-4d3f-beb2-7650e4309cb1</para>
        /// </summary>
        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The activation status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACTIVATED</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The activation step.</para>
        /// 
        /// <b>Example:</b>
        /// <para>步骤 &quot;初始化主机配置&quot; 执行成功</para>
        /// </summary>
        [NameInMap("step")]
        [Validation(Required=false)]
        public string Step { get; set; }

    }

}
