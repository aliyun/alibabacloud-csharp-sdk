// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListNamingTrackRequest : TeaModel {
        /// <summary>
        /// The language of the response. Valid values:
        /// 
        /// *   zh: Chinese
        /// *   en: English
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The end timestamp. Unit: seconds.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTs")]
        [Validation(Required=false)]
        public long? EndTs { get; set; }

        /// <summary>
        /// The group.
        /// </summary>
        [NameInMap("Group")]
        [Validation(Required=false)]
        public string Group { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The IP address of the client.
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// The ID of the namespace.
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The extended request parameters in the JSON format.
        /// </summary>
        [NameInMap("RequestPars")]
        [Validation(Required=false)]
        public string RequestPars { get; set; }

        /// <summary>
        /// Specifies whether to sort the query results in chronological order or reverse chronological order. Default value: `false`.
        /// 
        /// *   `true`: sorts the query results in reverse chronological order.
        /// *   `false`: sorts the query results in chronological order.
        /// </summary>
        [NameInMap("Reverse")]
        [Validation(Required=false)]
        public bool? Reverse { get; set; }

        /// <summary>
        /// The name of the service.
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// The start timestamp. Unit: seconds.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTs")]
        [Validation(Required=false)]
        public long? StartTs { get; set; }

    }

}
