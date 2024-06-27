/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class BindVariableRequest : TeaModel {
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("apiRegionId")]
        [Validation(Required=false)]
        public string ApiRegionId { get; set; }

        [NameInMap("apiType")]
        [Validation(Required=false)]
        public string ApiType { get; set; }

        [NameInMap("createType")]
        [Validation(Required=false)]
        public string CreateType { get; set; }

        [NameInMap("defineId")]
        [Validation(Required=false)]
        public string DefineId { get; set; }

        [NameInMap("defineIds")]
        [Validation(Required=false)]
        public string DefineIds { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("eventCode")]
        [Validation(Required=false)]
        public string EventCode { get; set; }

        [NameInMap("exceptionValue")]
        [Validation(Required=false)]
        public string ExceptionValue { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("outputField")]
        [Validation(Required=false)]
        public string OutputField { get; set; }

        [NameInMap("outputType")]
        [Validation(Required=false)]
        public string OutputType { get; set; }

        [NameInMap("params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        [NameInMap("paramsList")]
        [Validation(Required=false)]
        public string ParamsList { get; set; }

        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
