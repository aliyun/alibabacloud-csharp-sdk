// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class TagCustomPersonRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>CategoryDescription001-****</para>
        /// </summary>
        [NameInMap("CategoryDescription")]
        [Validation(Required=false)]
        public string CategoryDescription { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CategoryId001-****</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CategoryNametest-****</para>
        /// </summary>
        [NameInMap("CategoryName")]
        [Validation(Required=false)]
        public string CategoryName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PersonDescriptiontest-****</para>
        /// </summary>
        [NameInMap("PersonDescription")]
        [Validation(Required=false)]
        public string PersonDescription { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PersonId001-****</para>
        /// </summary>
        [NameInMap("PersonId")]
        [Validation(Required=false)]
        public string PersonId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PersonNametest-****</para>
        /// </summary>
        [NameInMap("PersonName")]
        [Validation(Required=false)]
        public string PersonName { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
