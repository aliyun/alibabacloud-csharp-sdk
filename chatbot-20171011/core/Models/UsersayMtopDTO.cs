// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class UsersayMtopDTO : TeaModel {
        /// <summary>
        /// Id
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// Data
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<SectionMtopDTO> Data { get; set; }

        /// <summary>
        /// Strict
        /// </summary>
        [NameInMap("Strict")]
        [Validation(Required=false)]
        public bool? Strict { get; set; }

    }

}
