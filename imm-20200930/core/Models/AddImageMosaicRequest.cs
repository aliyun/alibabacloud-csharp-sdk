// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class AddImageMosaicRequest : TeaModel {
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public CredentialConfig CredentialConfig { get; set; }

        [NameInMap("ImageFormat")]
        [Validation(Required=false)]
        public string ImageFormat { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("Quality")]
        [Validation(Required=false)]
        public int? Quality { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SourceURI")]
        [Validation(Required=false)]
        public string SourceURI { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TargetURI")]
        [Validation(Required=false)]
        public string TargetURI { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Targets")]
        [Validation(Required=false)]
        public List<AddImageMosaicRequestTargets> Targets { get; set; }
        public class AddImageMosaicRequestTargets : TeaModel {
            [NameInMap("BlurRadius")]
            [Validation(Required=false)]
            public int? BlurRadius { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Boundary")]
            [Validation(Required=false)]
            public AddImageMosaicRequestTargetsBoundary Boundary { get; set; }
            public class AddImageMosaicRequestTargetsBoundary : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public float? Height { get; set; }

                [NameInMap("ReferPos")]
                [Validation(Required=false)]
                public string ReferPos { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public float? Width { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public float? X { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public float? Y { get; set; }

            }

            [NameInMap("Color")]
            [Validation(Required=false)]
            public string Color { get; set; }

            [NameInMap("MosaicRadius")]
            [Validation(Required=false)]
            public int? MosaicRadius { get; set; }

            [NameInMap("Sigma")]
            [Validation(Required=false)]
            public int? Sigma { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
