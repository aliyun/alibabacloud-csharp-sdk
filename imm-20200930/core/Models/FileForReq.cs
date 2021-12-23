// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class FileForReq : TeaModel {
        /// <summary>
        /// ContentType
        /// </summary>
        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// CustomId
        /// </summary>
        [NameInMap("CustomId")]
        [Validation(Required=false)]
        public string CustomId { get; set; }

        /// <summary>
        /// CustomLabels
        /// </summary>
        [NameInMap("CustomLabels")]
        [Validation(Required=false)]
        public Dictionary<string, object> CustomLabels { get; set; }

        /// <summary>
        /// Figures
        /// </summary>
        [NameInMap("Figures")]
        [Validation(Required=false)]
        public List<FileForReqFigures> Figures { get; set; }
        public class FileForReqFigures : TeaModel {
            /// <summary>
            /// FigureClusterId
            /// </summary>
            [NameInMap("FigureClusterId")]
            [Validation(Required=false)]
            public string FigureClusterId { get; set; }

            /// <summary>
            /// FigureId
            /// </summary>
            [NameInMap("FigureId")]
            [Validation(Required=false)]
            public string FigureId { get; set; }

            /// <summary>
            /// FigureType
            /// </summary>
            [NameInMap("FigureType")]
            [Validation(Required=false)]
            public string FigureType { get; set; }

        }

        /// <summary>
        /// FileHash
        /// </summary>
        [NameInMap("FileHash")]
        [Validation(Required=false)]
        public string FileHash { get; set; }

        /// <summary>
        /// MediaType
        /// </summary>
        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public string MediaType { get; set; }

        /// <summary>
        /// OSSURI
        /// </summary>
        [NameInMap("OSSURI")]
        [Validation(Required=false)]
        public string OSSURI { get; set; }

        /// <summary>
        /// URI
        /// </summary>
        [NameInMap("URI")]
        [Validation(Required=false)]
        public string URI { get; set; }

    }

}
