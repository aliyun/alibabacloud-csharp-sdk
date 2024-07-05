// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ListFpShotDBResponseBody : TeaModel {
        /// <summary>
        /// The media fingerprint libraries.
        /// </summary>
        [NameInMap("FpShotDBList")]
        [Validation(Required=false)]
        public ListFpShotDBResponseBodyFpShotDBList FpShotDBList { get; set; }
        public class ListFpShotDBResponseBodyFpShotDBList : TeaModel {
            [NameInMap("FpShotDB")]
            [Validation(Required=false)]
            public List<ListFpShotDBResponseBodyFpShotDBListFpShotDB> FpShotDB { get; set; }
            public class ListFpShotDBResponseBodyFpShotDBListFpShotDB : TeaModel {
                /// <summary>
                /// The description of the media fingerprint library.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The ID of the media fingerprint library.
                /// </summary>
                [NameInMap("FpDBId")]
                [Validation(Required=false)]
                public string FpDBId { get; set; }

                /// <summary>
                /// The model ID of the media fingerprint library. A value of **11** indicates that the library is a text fingerprint library. A value of **12** indicates that the library is a video fingerprint library. A value of **13** indicates that the library is an audio fingerprint library. A value of **14** indicates that the library is an image fingerprint library.
                /// </summary>
                [NameInMap("ModelId")]
                [Validation(Required=false)]
                public int? ModelId { get; set; }

                /// <summary>
                /// The name of the media fingerprint library.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The status of the media fingerprint library. Default value: **offline**. ****Valid values:
                /// 
                /// *   **offline**: The media fingerprint library is offline.
                /// *   **active**: The media fingerprint library is online.
                /// *   **paused**: The media fingerprint library is paused.
                /// *   **deleted**: The media fingerprint library is deleted.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// The IDs of the media fingerprint libraries that do not exist.
        /// </summary>
        [NameInMap("NonExistIds")]
        [Validation(Required=false)]
        public ListFpShotDBResponseBodyNonExistIds NonExistIds { get; set; }
        public class ListFpShotDBResponseBodyNonExistIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
