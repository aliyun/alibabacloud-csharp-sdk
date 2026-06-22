// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListProductRequest : TeaModel {
        /// <summary>
        /// <para>The cursor that points to the start of the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kdkii48jfjjei3</para>
        /// </summary>
        [NameInMap("After")]
        [Validation(Required=false)]
        public string After { get; set; }

        /// <summary>
        /// <para>The cursor that points to the end of the previous page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wiidkd939kek93</para>
        /// </summary>
        [NameInMap("Before")]
        [Validation(Required=false)]
        public string Before { get; set; }

        /// <summary>
        /// <para>The catalog ID. You can get it from the Meta platform.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2939838xxxx</para>
        /// </summary>
        [NameInMap("CatalogId")]
        [Validation(Required=false)]
        public string CatalogId { get; set; }

        /// <summary>
        /// <para>The Space ID of the ISV sub-customer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C2939838xxxx</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// <para>A list of fields to return. Separate multiple fields with a comma (,).
        /// For more information, see <a href="https://help.aliyun.com/document_detail/2579419.html">Product fields</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>id,name</para>
        /// </summary>
        [NameInMap("Fields")]
        [Validation(Required=false)]
        public string Fields { get; set; }

        /// <summary>
        /// <para>The number of items to return. Valid values: 1 to 1000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>73</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The WhatsApp Business Account (WABA) ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3848747xxxx</para>
        /// </summary>
        [NameInMap("WabaId")]
        [Validation(Required=false)]
        public string WabaId { get; set; }

    }

}
