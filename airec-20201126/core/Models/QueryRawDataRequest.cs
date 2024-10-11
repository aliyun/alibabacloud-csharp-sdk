// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class QueryRawDataRequest : TeaModel {
        [NameInMap("imei")]
        [Validation(Required=false)]
        public string Imei { get; set; }

        /// <summary>
        /// <para>The item ID. This parameter is required when the table parameter is set to item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>112</para>
        /// </summary>
        [NameInMap("itemId")]
        [Validation(Required=false)]
        public string ItemId { get; set; }

        /// <summary>
        /// <para>The type of the item. This parameter is required when the table parameter is set to item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>video</para>
        /// </summary>
        [NameInMap("itemType")]
        [Validation(Required=false)]
        public string ItemType { get; set; }

        /// <summary>
        /// <para>The user ID. This parameter is required when the table parameter is set to user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>111</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The type of the user. This parameter is required when the table parameter is set to user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app</para>
        /// </summary>
        [NameInMap("userType")]
        [Validation(Required=false)]
        public string UserType { get; set; }

    }

}
