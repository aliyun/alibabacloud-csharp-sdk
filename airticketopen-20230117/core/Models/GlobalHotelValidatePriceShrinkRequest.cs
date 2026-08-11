// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class GlobalHotelValidatePriceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The distributor account ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("AccountNo")]
        [Validation(Required=false)]
        public long? AccountNo { get; set; }

        /// <summary>
        /// <para>The number of adults per room.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Adults")]
        [Validation(Required=false)]
        public int? Adults { get; set; }

        /// <summary>
        /// <para>The number of children per room.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Children")]
        [Validation(Required=false)]
        public int? Children { get; set; }

        /// <summary>
        /// <para>The list of children ages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[8]</para>
        /// </summary>
        [NameInMap("ChildrenAges")]
        [Validation(Required=false)]
        public string ChildrenAgesShrink { get; set; }

        /// <summary>
        /// <para>The offer key.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>itemOfferKey_abc123</para>
        /// </summary>
        [NameInMap("ItemOfferKey")]
        [Validation(Required=false)]
        public string ItemOfferKey { get; set; }

        /// <summary>
        /// <para>The number of rooms.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RoomCount")]
        [Validation(Required=false)]
        public int? RoomCount { get; set; }

        /// <summary>
        /// <para>TracerId</para>
        /// 
        /// <b>Example:</b>
        /// <para>TracerId</para>
        /// </summary>
        [NameInMap("TracerId")]
        [Validation(Required=false)]
        public string TracerId { get; set; }

    }

}
