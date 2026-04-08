// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appflow20230904.Models
{
    public class InvokeActionShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>action-xxx</para>
        /// </summary>
        [NameInMap("ActionId")]
        [Validation(Required=false)]
        public string ActionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ActionVersion")]
        [Validation(Required=false)]
        public string ActionVersion { get; set; }

        [NameInMap("AuthConfig")]
        [Validation(Required=false)]
        public string AuthConfigShrink { get; set; }

        [NameInMap("Body")]
        [Validation(Required=false)]
        public string BodyShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>connector-xxx</para>
        /// </summary>
        [NameInMap("ConnectorId")]
        [Validation(Required=false)]
        public string ConnectorId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ConnectorVersion")]
        [Validation(Required=false)]
        public string ConnectorVersion { get; set; }

        [NameInMap("Headers")]
        [Validation(Required=false)]
        public string HeadersShrink { get; set; }

        [NameInMap("Path")]
        [Validation(Required=false)]
        public string PathShrink { get; set; }

        [NameInMap("Query")]
        [Validation(Required=false)]
        public string QueryShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

    }

}
