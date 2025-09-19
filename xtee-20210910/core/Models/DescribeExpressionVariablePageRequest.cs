// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeExpressionVariablePageRequest : TeaModel {
        /// <summary>
        /// <para>Sets the language type for requests and received messages, with a default value of <b>zh</b>. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Current page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>Event code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>de_aamexg3015,de_aamexg3342</para>
        /// </summary>
        [NameInMap("eventCode")]
        [Validation(Required=false)]
        public string EventCode { get; set; }

        /// <summary>
        /// <para>Variable return type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>STRING</para>
        /// </summary>
        [NameInMap("outputs")]
        [Validation(Required=false)]
        public string Outputs { get; set; }

        /// <summary>
        /// <para>Page size, with a default value of 10.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>Region code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <para>Status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENABLE</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Variable name/description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>自定义变量</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
