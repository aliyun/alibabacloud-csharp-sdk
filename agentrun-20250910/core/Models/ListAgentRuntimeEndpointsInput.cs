// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ListAgentRuntimeEndpointsInput : TeaModel {
        /// <summary>
        /// <para>Filter by endpoint name</para>
        /// </summary>
        [NameInMap("endpointName")]
        [Validation(Required=false)]
        public string EndpointName { get; set; }

        /// <summary>
        /// <para>Page number</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Number of records per page</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Filter by status</para>
        /// </summary>
        [NameInMap("statuses")]
        [Validation(Required=false)]
        public List<string> Statuses { get; set; }

    }

}
