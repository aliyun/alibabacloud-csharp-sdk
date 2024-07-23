// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ListCustomPersonsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the figure library about which you want to query information. The ID is used to uniquely identify a custom figure library. Make sure that the ID is unique. If you do not specify this parameter, the operation returns all the custom figure libraries. The ID can be up to 120 characters in length and is not case-sensitive.</para>
        /// <remarks>
        /// <para>You cannot specify the ID of the system figure library for this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>CategoryId-****</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public string CategoryId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the figure about which you want to query information. The ID is used to uniquely identify a figure. Make sure that the ID is unique. If you do not specify this parameter, the operation returns the information about all the figures in the specified figure library.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PersonId-****</para>
        /// </summary>
        [NameInMap("PersonId")]
        [Validation(Required=false)]
        public string PersonId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
