// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricRuleTemplateAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The name of the alert template. You must specify at least one of the <c>Name</c> and <c>TemplateId</c> parameters.</para>
        /// <para>For information about how to obtain the name of an alert template, see <a href="https://help.aliyun.com/document_detail/114982.html">DescribeMetricRuleTemplateList</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS_Template1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the alert template. You must specify at least one of the <c>Name</c> and <c>TemplateId</c> parameters.</para>
        /// <para>For information about how to obtain the ID of an alert template, see <a href="https://help.aliyun.com/document_detail/114982.html">DescribeMetricRuleTemplateList</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
