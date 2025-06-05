// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListRecognitionEntitiesResponseBody : TeaModel {
        [NameInMap("Entities")]
        [Validation(Required=false)]
        public ListRecognitionEntitiesResponseBodyEntities Entities { get; set; }
        public class ListRecognitionEntitiesResponseBodyEntities : TeaModel {
            [NameInMap("Entity")]
            [Validation(Required=false)]
            public List<ListRecognitionEntitiesResponseBodyEntitiesEntity> Entity { get; set; }
            public class ListRecognitionEntitiesResponseBodyEntitiesEntity : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>**<b><b><b><b><b><b>544cb84754</b></b></b></b></b></b></para>
                /// </summary>
                [NameInMap("EntityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("EntityInfo")]
                [Validation(Required=false)]
                public string EntityInfo { get; set; }

                [NameInMap("EntityName")]
                [Validation(Required=false)]
                public string EntityName { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
