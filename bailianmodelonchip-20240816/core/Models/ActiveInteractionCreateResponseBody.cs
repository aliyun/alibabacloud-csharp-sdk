// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BailianModelOnChip20240816.Models
{
    public class ActiveInteractionCreateResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ActiveInteractionCreateResponseBodyData Data { get; set; }
        public class ActiveInteractionCreateResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>point</para>
            /// </summary>
            [NameInMap("gesture")]
            [Validation(Required=false)]
            public string Gesture { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>A man in dark clothing stands on a rocky hilltop, facing away from the camera, gazing at the expansive view with a contemplative posture.</para>
            /// </summary>
            [NameInMap("person")]
            [Validation(Required=false)]
            public string Person { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Mountainous landscape with layered ridges receding into haze, under a vast blue sky with wispy clouds and soft golden light near the horizon.</para>
            /// </summary>
            [NameInMap("scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>AF54F772-60FF-56FD-A3EA-11620EF1229A</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
