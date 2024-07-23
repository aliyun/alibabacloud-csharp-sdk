// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ListFpShotDBResponseBody : TeaModel {
        /// <summary>
        /// <para>The media fingerprint libraries.</para>
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
                /// <para>The description of the media fingerprint library.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The library is a text fingerprint library.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the media fingerprint library.</para>
                /// 
                /// <b>Example:</b>
                /// <para>88c6ca184c0e47098a5b665e2a12****</para>
                /// </summary>
                [NameInMap("FpDBId")]
                [Validation(Required=false)]
                public string FpDBId { get; set; }

                /// <summary>
                /// <para>The model ID of the media fingerprint library. A value of <b>11</b> indicates that the library is a text fingerprint library. A value of <b>12</b> indicates that the library is a video fingerprint library. A value of <b>13</b> indicates that the library is an audio fingerprint library. A value of <b>14</b> indicates that the library is an image fingerprint library.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("ModelId")]
                [Validation(Required=false)]
                public int? ModelId { get; set; }

                /// <summary>
                /// <para>The name of the media fingerprint library.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-****</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The status of the media fingerprint library. Default value: <b>offline</b>. ****Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>offline</b>: The media fingerprint library is offline.</description></item>
                /// <item><description><b>active</b>: The media fingerprint library is online.</description></item>
                /// <item><description><b>paused</b>: The media fingerprint library is paused.</description></item>
                /// <item><description><b>deleted</b>: The media fingerprint library is deleted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>active</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The IDs of the media fingerprint libraries that do not exist.</para>
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
