// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appflow20230904.Models
{
    public class InvokeActionShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The action ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>action-xxx</para>
        /// </summary>
        [NameInMap("ActionId")]
        [Validation(Required=false)]
        public string ActionId { get; set; }

        /// <summary>
        /// <para>The action version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ActionVersion")]
        [Validation(Required=false)]
        public string ActionVersion { get; set; }

        /// <summary>
        /// <para>The authentication information for the action.</para>
        /// </summary>
        [NameInMap("AuthConfig")]
        [Validation(Required=false)]
        public string AuthConfigShrink { get; set; }

        /// <summary>
        /// <para>The request body for the action.</para>
        /// </summary>
        [NameInMap("Body")]
        [Validation(Required=false)]
        public string BodyShrink { get; set; }

        /// <summary>
        /// <para>The connector ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>connector-xxx</para>
        /// </summary>
        [NameInMap("ConnectorId")]
        [Validation(Required=false)]
        public string ConnectorId { get; set; }

        /// <summary>
        /// <para>The connector version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ConnectorVersion")]
        [Validation(Required=false)]
        public string ConnectorVersion { get; set; }

        /// <summary>
        /// <para>The request header parameters for the action.</para>
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public string HeadersShrink { get; set; }

        /// <summary>
        /// <para>The path parameters for the action.</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string PathShrink { get; set; }

        /// <summary>
        /// <para>The query parameters for the action.</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string QueryShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether to use streaming output.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

    }

}
