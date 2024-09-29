// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SearchAlertContactGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the alert contact group. You can query multiple alert contact groups at a time. Separate multiple group IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>746</para>
        /// </summary>
        [NameInMap("ContactGroupIds")]
        [Validation(Required=false)]
        public string ContactGroupIds { get; set; }

        /// <summary>
        /// <para>The name of the alert contact group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestGroup</para>
        /// </summary>
        [NameInMap("ContactGroupName")]
        [Validation(Required=false)]
        public string ContactGroupName { get; set; }

        /// <summary>
        /// <para>The ID of the alert contact. You can call the SearchAlertContact operation to query the contact IDs. For more information, see <a href="https://help.aliyun.com/document_detail/130703.html">SearchAlertContact</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("ContactId")]
        [Validation(Required=false)]
        public long? ContactId { get; set; }

        /// <summary>
        /// <para>The name of the alert contact.</para>
        /// 
        /// <b>Example:</b>
        /// <para>John Doe</para>
        /// </summary>
        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        /// <summary>
        /// <para>Specifies whether to return all alert contacts in the queried alert contact group. By default, not all alert contacts are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsDetail")]
        [Validation(Required=false)]
        public bool? IsDetail { get; set; }

        /// <summary>
        /// <para>The ID of the region. Default value: <c>cn-hangzhou</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
