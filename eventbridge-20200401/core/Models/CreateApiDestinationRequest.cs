// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class CreateApiDestinationRequest : TeaModel {
        /// <summary>
        /// <para>The name of the API destination. The name must be 2 to 127 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api-destination-name</para>
        /// </summary>
        [NameInMap("ApiDestinationName")]
        [Validation(Required=false)]
        public string ApiDestinationName { get; set; }

        /// <summary>
        /// <para>The name of the connection. The name must be 2 to 127 characters in length.</para>
        /// <remarks>
        /// <para> Before you configure this parameter, you must call the CreateConnection operation to create a connection. Then, set this parameter to the name of the connection that you created.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>connection-name</para>
        /// </summary>
        [NameInMap("ConnectionName")]
        [Validation(Required=false)]
        public string ConnectionName { get; set; }

        /// <summary>
        /// <para>The description of the API destination. The description can be up to 255 characters in length.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The parameters that are configured for the API destination.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("HttpApiParameters")]
        [Validation(Required=false)]
        public CreateApiDestinationRequestHttpApiParameters HttpApiParameters { get; set; }
        public class CreateApiDestinationRequestHttpApiParameters : TeaModel {
            /// <summary>
            /// <para>The endpoint of the API destination. The endpoint can be up to 127 characters in length.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://127.0.0.1:8001/api">http://127.0.0.1:8001/api</a></para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The HTTP request method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>GET</description></item>
            /// <item><description>POST</description></item>
            /// <item><description>HEAD</description></item>
            /// <item><description>DELETE</description></item>
            /// <item><description>PUT</description></item>
            /// <item><description>PATCH</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>POST</para>
            /// </summary>
            [NameInMap("Method")]
            [Validation(Required=false)]
            public string Method { get; set; }

        }

    }

}
