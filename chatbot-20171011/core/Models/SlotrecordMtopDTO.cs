// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class SlotrecordMtopDTO : TeaModel {
        /// <summary>
        /// Id
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// Question
        /// </summary>
        [NameInMap("Question")]
        [Validation(Required=false)]
        public List<string> Question { get; set; }

        /// <summary>
        /// LifeSpan
        /// </summary>
        [NameInMap("LifeSpan")]
        [Validation(Required=false)]
        public int? LifeSpan { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// IsArray
        /// </summary>
        [NameInMap("IsArray")]
        [Validation(Required=false)]
        public bool? IsArray { get; set; }

        /// <summary>
        /// Value
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        /// <summary>
        /// IsNecessary
        /// </summary>
        [NameInMap("IsNecessary")]
        [Validation(Required=false)]
        public bool? IsNecessary { get; set; }

        /// <summary>
        /// Tags
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<TagMtopDTO> Tags { get; set; }

    }

}
