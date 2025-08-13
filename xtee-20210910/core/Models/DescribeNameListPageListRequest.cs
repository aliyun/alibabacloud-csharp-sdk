// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeNameListPageListRequest : TeaModel {
        /// <summary>
        /// <para>Sets the language type for requests and received messages, default value is <b>zh</b>. Values:</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Page size, default value is 10</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Region code</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <para>Update start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1753372800000</para>
        /// </summary>
        [NameInMap("updateBeginTime")]
        [Validation(Required=false)]
        public long? UpdateBeginTime { get; set; }

        /// <summary>
        /// <para>Update end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1753459199059</para>
        /// </summary>
        [NameInMap("updateEndTime")]
        [Validation(Required=false)]
        public long? UpdateEndTime { get; set; }

        /// <summary>
        /// <para>Variable name/description</para>
        /// 
        /// <b>Example:</b>
        /// <para>白名单</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        /// <summary>
        /// <para>Variable ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>762</para>
        /// </summary>
        [NameInMap("variableId")]
        [Validation(Required=false)]
        public long? VariableId { get; set; }

    }

}
