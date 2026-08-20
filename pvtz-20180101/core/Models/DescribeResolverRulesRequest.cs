// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeResolverRulesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the outbound endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hr****</para>
        /// </summary>
        [NameInMap("EndpointId")]
        [Validation(Required=false)]
        public string EndpointId { get; set; }

        /// <summary>
        /// <para>The keyword for the name of the forwarding rule. The search is case-insensitive and supports fuzzy match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>zh: Chinese.</para>
        /// </description></item>
        /// <item><description><para>en: English.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: en</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the list of virtual private clouds (VPCs) that are associated with the forwarding rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: returns the list.</para>
        /// </description></item>
        /// <item><description><para>false: does not return the list.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NeedDetailAttributes")]
        [Validation(Required=false)]
        public bool? NeedDetailAttributes { get; set; }

        /// <summary>
        /// <para>The number of the page to return. The start value is 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Maximum value: 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
