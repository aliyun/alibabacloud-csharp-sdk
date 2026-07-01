// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListDNADBResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried media fingerprint libraries.</para>
        /// </summary>
        [NameInMap("DBList")]
        [Validation(Required=false)]
        public List<ListDNADBResponseBodyDBList> DBList { get; set; }
        public class ListDNADBResponseBodyDBList : TeaModel {
            /// <summary>
            /// <para>The ID of the media fingerprint library.</para>
            /// 
            /// <b>Example:</b>
            /// <para>88c6ca184c0e47098a5b665e2a12****</para>
            /// </summary>
            [NameInMap("DBId")]
            [Validation(Required=false)]
            public string DBId { get; set; }

            /// <summary>
            /// <para>The description of the media fingerprint library.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is a video DNA library.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The model of the media fingerprint library. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Video</b></para>
            /// </description></item>
            /// <item><description><para><b>Audio</b></para>
            /// </description></item>
            /// <item><description><para><b>Image</b></para>
            /// </description></item>
            /// <item><description><para><b>Text</b> (supported only in the China (Shanghai) region)</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Video</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>The name of the media fingerprint library.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The state of the media fingerprint library. Default value: <b>offline</b>. \<em>\</em>\*\*Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>offline</b>: The media fingerprint library is offline.</para>
            /// </description></item>
            /// <item><description><para><b>active</b>: The media fingerprint library is online.</para>
            /// </description></item>
            /// <item><description><para><b>deleted</b>: The media fingerprint library is deleted.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4A13-BEF6-D7393642CA58</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
