// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class ListSupportResourceTypesRequest : TeaModel {
        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <para>Maximum value: 1000. Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResult")]
        [Validation(Required=false)]
        public int? MaxResult { get; set; }

        /// <summary>
        /// <para>The token that is used to start the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAYws9fJ0Ur4MGm/5OkDoW/Y3wDNwUdssyKODK****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The service code. This parameter specifies a filter condition for the query.</para>
        /// <para>This parameter is obtained from the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>For more information about region IDs, see <a href="https://help.aliyun.com/document_detail/2330902.html">Endpoints</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The resource type. This parameter specifies a filter condition for the query.</para>
        /// <para>This parameter is obtained from the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance</para>
        /// </summary>
        [NameInMap("ResourceTye")]
        [Validation(Required=false)]
        public string ResourceTye { get; set; }

        /// <summary>
        /// <para>Specifies whether to return tag-related capability items. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The system returns tag-related capability items.</description></item>
        /// <item><description>false (default value): The system does not return tag-related capability items.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ShowItems")]
        [Validation(Required=false)]
        public bool? ShowItems { get; set; }

        /// <summary>
        /// <para>The code of the tag-related capability item. This parameter specifies a filter condition for the query.</para>
        /// <para>For more information, see <b>Tag-related capability items</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TAG_CONSOLE_SUPPORT</para>
        /// </summary>
        [NameInMap("SupportCode")]
        [Validation(Required=false)]
        public string SupportCode { get; set; }

    }

}
