// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class CreateDcdnWafGroupRequest : TeaModel {
        /// <summary>
        /// <para>The name of the WAF rule group. The name can be up to 128 characters in length. This parameter is required when you create a custom WAF rule group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable subscription. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b></description></item>
        /// <item><description><b>off</b></description></item>
        /// </list>
        /// <para>When you replicate a custom rule group, do not specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Subscribe")]
        [Validation(Required=false)]
        public string Subscribe { get; set; }

        /// <summary>
        /// <para>The ID of the rule group to be replicated. This parameter is required when you replicate a custom WAF rule group. You can call the <a href="~~DescribeDcdnWafGroups~~">DescribeDcdnWafGroups</a> operation to query the ID of the rule group. If no template is used, set the value to 0 or do not specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

    }

}
