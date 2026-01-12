// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.XrEngine20221111.Models
{
    public class CreateProjectRequest : TeaModel {
        [NameInMap("AutoBuild")]
        [Validation(Required=false)]
        public bool? AutoBuild { get; set; }

        [NameInMap("Dependencies")]
        [Validation(Required=false)]
        public string Dependencies { get; set; }

        [NameInMap("ExtInfo")]
        [Validation(Required=false)]
        public string ExtInfo { get; set; }

        [NameInMap("Gender")]
        [Validation(Required=false)]
        public string Gender { get; set; }

        [NameInMap("Height")]
        [Validation(Required=false)]
        public double? Height { get; set; }

        [NameInMap("Intro")]
        [Validation(Required=false)]
        public string Intro { get; set; }

        [NameInMap("JwtToken")]
        [Validation(Required=false)]
        public string JwtToken { get; set; }

        [NameInMap("MapUuid")]
        [Validation(Required=false)]
        public string MapUuid { get; set; }

        [NameInMap("Method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("TryOnParams")]
        [Validation(Required=false)]
        public CreateProjectRequestTryOnParams TryOnParams { get; set; }
        public class CreateProjectRequestTryOnParams : TeaModel {
            [NameInMap("ClothIds")]
            [Validation(Required=false)]
            public List<long?> ClothIds { get; set; }

            [NameInMap("ClothInfos")]
            [Validation(Required=false)]
            public List<CreateProjectRequestTryOnParamsClothInfos> ClothInfos { get; set; }
            public class CreateProjectRequestTryOnParamsClothInfos : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Size")]
                [Validation(Required=false)]
                public string Size { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("Weight")]
        [Validation(Required=false)]
        public double? Weight { get; set; }

    }

}
