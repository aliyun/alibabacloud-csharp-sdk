// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListProductCatalogRequest : TeaModel {
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
        /// <para>The Business Manager ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>28</para>
        /// </summary>
        [NameInMap("BusinessId")]
        [Validation(Required=false)]
        public long? BusinessId { get; set; }

        /// <summary>
        /// <para>The space ID of the user within the independent software vendor (ISV) account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>293483938849493</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// <para>The fields. Separate multiple fields with commas (,).
        /// see  <a href="https://help.aliyun.com/document_detail/2579419.html">catalog fields</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>id,name</para>
        /// </summary>
        [NameInMap("Fields")]
        [Validation(Required=false)]
        public string Fields { get; set; }

        /// <summary>
        /// <para>The number of catalogs to be queried. Valid values: 1 to 1000.</para>
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

    }

}
