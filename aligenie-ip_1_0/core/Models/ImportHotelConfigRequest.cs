// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class ImportHotelConfigRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ImportHotelConfig")]
        [Validation(Required=false)]
        public ImportHotelConfigRequestImportHotelConfig ImportHotelConfig { get; set; }
        public class ImportHotelConfigRequestImportHotelConfig : TeaModel {
            [NameInMap("RcuCustomScenes")]
            [Validation(Required=false)]
            public List<ImportHotelConfigRequestImportHotelConfigRcuCustomScenes> RcuCustomScenes { get; set; }
            public class ImportHotelConfigRequestImportHotelConfigRcuCustomScenes : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("CorpusList")]
                [Validation(Required=false)]
                public List<string> CorpusList { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("SceneId")]
                [Validation(Required=false)]
                public string SceneId { get; set; }

            }

        }

    }

}
