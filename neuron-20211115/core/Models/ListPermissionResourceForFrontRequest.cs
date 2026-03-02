// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class ListPermissionResourceForFrontRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>VIEW</para>
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>41</para>
        /// </summary>
        [NameInMap("enterpriseId")]
        [Validation(Required=false)]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>292758960042264423</para>
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DEVELOPER</para>
        /// </summary>
        [NameInMap("operatorType")]
        [Validation(Required=false)]
        public string OperatorType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CONTAIN_MATCH</para>
        /// </summary>
        [NameInMap("queryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>neuron:catalog:company/1</para>
        /// </summary>
        [NameInMap("resourcePrefix")]
        [Validation(Required=false)]
        public string ResourcePrefix { get; set; }

    }

}
