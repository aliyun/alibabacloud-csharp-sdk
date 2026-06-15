// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class QueryReceiverByParamRequest : TeaModel {
        /// <summary>
        /// <para>The keyword to search for recipient lists. If omitted, all recipient lists are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mesh-notification</para>
        /// </summary>
        [NameInMap("KeyWord")]
        [Validation(Required=false)]
        public string KeyWord { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>This deprecated field is kept for backward compatibility. You can omit this parameter.</para>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The page size. Default value: 100.</para>
        /// <para>Omitting this parameter returns all results. However, because the PageNo parameter is deprecated, the effect of PageSize on pagination is limited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>This deprecated field is kept for backward compatibility. You can omit this parameter.</para>
        /// <para>The list status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: uploading</para>
        /// </description></item>
        /// <item><description><para>1: upload complete</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
