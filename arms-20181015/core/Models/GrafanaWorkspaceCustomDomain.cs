// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20181015.Models
{
    public class GrafanaWorkspaceCustomDomain : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>protocol为http时无需填写;</para>
        /// </summary>
        [NameInMap("cert")]
        [Validation(Required=false)]
        public string Cert { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1688627798017</para>
        /// </summary>
        [NameInMap("date")]
        [Validation(Required=false)]
        public long? Date { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>mydomain.com</para>
        /// </summary>
        [NameInMap("domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>grafana-cn-***********</para>
        /// </summary>
        [NameInMap("grafanaWorkspaceId")]
        [Validation(Required=false)]
        public string GrafanaWorkspaceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>protocol为http时无需填写;</para>
        /// </summary>
        [NameInMap("key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("privateZone")]
        [Validation(Required=false)]
        public string PrivateZone { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>https</para>
        /// </summary>
        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CreateSucceed</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

    }

}
