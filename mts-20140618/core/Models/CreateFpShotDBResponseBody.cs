// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class CreateFpShotDBResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the media fingerprint library.</para>
        /// </summary>
        [NameInMap("FpShotDB")]
        [Validation(Required=false)]
        public CreateFpShotDBResponseBodyFpShotDB FpShotDB { get; set; }
        public class CreateFpShotDBResponseBodyFpShotDB : TeaModel {
            /// <summary>
            /// <para>The configurations of the media fingerprint library.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

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
            /// <para>The ID of the media fingerprint library. We recommend that you keep this ID for subsequent operation calls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>88c6ca184c0e47098a5b665e2a12****</para>
            /// </summary>
            [NameInMap("FpDBId")]
            [Validation(Required=false)]
            public string FpDBId { get; set; }

            /// <summary>
            /// <para>The model ID of the media fingerprint library.</para>
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
            /// <para>example-name-****</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The status of the media fingerprint library. After the media fingerprint library is created, it enters the <b>offline</b> state. After the media fingerprint library is processed at the backend, it enters the <b>active</b> state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>offline</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

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
