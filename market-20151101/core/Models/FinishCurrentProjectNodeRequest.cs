// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class FinishCurrentProjectNodeRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID of the Alibaba Cloud Marketplace order.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4****89</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the process node.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1924</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public long? NodeId { get; set; }

        /// <summary>
        /// <para>The remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>收货地址已提交，请尽快安排发货。</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The form content to submit, in JSON format. Example: {&quot;TFD0&quot;:&quot;mr.go&quot;,&quot;TFD1&quot;:&quot;1330010xxxx&quot;,&quot;TFD2&quot;:&quot;Chaoyang District, Wangjing Street, Block x, No. y&quot;}.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;TFD0&quot;: &quot;Mr.Go&quot;,&quot;TFD1&quot;: &quot;1330010xxxx&quot;,&quot;TFD2&quot;: &quot;北京市朝阳区望京街道X区Y号&quot; }</para>
        /// </summary>
        [NameInMap("TemplateForm")]
        [Validation(Required=false)]
        public string TemplateForm { get; set; }

    }

}
