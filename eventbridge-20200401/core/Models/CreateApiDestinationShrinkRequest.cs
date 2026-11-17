// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class CreateApiDestinationShrinkRequest : TeaModel {
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
        /// <para>The name of the connection configuration. The name must be 2 to 127 characters in length.
        /// <notice>You must first call the Connection operation to create a connection configuration, and specify an existing connection name for ConnectionName.</notice></para>
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
        /// 
        /// <b>Example:</b>
        /// <para>This is the description.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The configuration information of the API destination.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("HttpApiParameters")]
        [Validation(Required=false)]
        public string HttpApiParametersShrink { get; set; }

    }

}
