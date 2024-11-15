// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListProductRequest : TeaModel {
        /// <summary>
        /// <para>The cursor that points to the end of the page of the returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kdkii48jfjjei3</para>
        /// </summary>
        [NameInMap("After")]
        [Validation(Required=false)]
        public string After { get; set; }

        /// <summary>
        /// <para>The cursor that points to the beginning of the page of the returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wiidkd939kek93</para>
        /// </summary>
        [NameInMap("Before")]
        [Validation(Required=false)]
        public string Before { get; set; }

        /// <summary>
        /// <para>The catalog ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>29398389292</para>
        /// </summary>
        [NameInMap("CatalogId")]
        [Validation(Required=false)]
        public string CatalogId { get; set; }

        /// <summary>
        /// <para>The space ID of the user within the independent software vendor (ISV) account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C29398388383</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// <para>The fields. Separate multiple fields with commas (,).</para>
        /// <para> see <a href="https://help.aliyun.com/document_detail/2579419.html">product fields</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>id,name</para>
        /// </summary>
        [NameInMap("Fields")]
        [Validation(Required=false)]
        public string Fields { get; set; }

        /// <summary>
        /// <para>The number of products to be queried. Valid values: 1 to 1000.</para>
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
        /// <para>The ID of the WhatsApp Business account (WABA).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>38487474747</para>
        /// </summary>
        [NameInMap("WabaId")]
        [Validation(Required=false)]
        public string WabaId { get; set; }

    }

}
