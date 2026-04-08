// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class QueryTrafficControlTaskDeployResultResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>deploy job draft success</para>
        /// </summary>
        [NameInMap("DeployMessage")]
        [Validation(Required=false)]
        public string DeployMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("DeployStatus")]
        [Validation(Required=false)]
        public string DeployStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>push draft success</para>
        /// </summary>
        [NameInMap("DraftMessage")]
        [Validation(Required=false)]
        public string DraftMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("DraftStatus")]
        [Validation(Required=false)]
        public string DraftStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("PrepareMessage")]
        [Validation(Required=false)]
        public string PrepareMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("PrepareStatus")]
        [Validation(Required=false)]
        public string PrepareStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>728C5E01-ABF6-5AA8-B9FC-B3BA05DECC77</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>start job success</para>
        /// </summary>
        [NameInMap("StartMessage")]
        [Validation(Required=false)]
        public string StartMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("StartStatus")]
        [Validation(Required=false)]
        public string StartStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TrafficControlTaskId")]
        [Validation(Required=false)]
        public string TrafficControlTaskId { get; set; }

    }

}
