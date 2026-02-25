// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ListFpShotDBResponseBody : TeaModel {
        [NameInMap("FpShotDBList")]
        [Validation(Required=false)]
        public ListFpShotDBResponseBodyFpShotDBList FpShotDBList { get; set; }
        public class ListFpShotDBResponseBodyFpShotDBList : TeaModel {
            [NameInMap("FpShotDB")]
            [Validation(Required=false)]
            public List<ListFpShotDBResponseBodyFpShotDBListFpShotDB> FpShotDB { get; set; }
            public class ListFpShotDBResponseBodyFpShotDBListFpShotDB : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("FpDBId")]
                [Validation(Required=false)]
                public string FpDBId { get; set; }

                [NameInMap("ModelId")]
                [Validation(Required=false)]
                public int? ModelId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        [NameInMap("NonExistIds")]
        [Validation(Required=false)]
        public ListFpShotDBResponseBodyNonExistIds NonExistIds { get; set; }
        public class ListFpShotDBResponseBodyNonExistIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4A13-BEF6-D7393642CA58</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
