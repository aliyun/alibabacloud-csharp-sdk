// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160201.Models
{
    public class ModifyApiRequest : TeaModel {
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public string ApiId { get; set; }

        [NameInMap("ApiName")]
        [Validation(Required=false)]
        public string ApiName { get; set; }

        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        [NameInMap("BodyFormat")]
        [Validation(Required=false)]
        public string BodyFormat { get; set; }

        [NameInMap("ConstantParameters")]
        [Validation(Required=false)]
        public string ConstantParameters { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("HttpMethod")]
        [Validation(Required=false)]
        public string HttpMethod { get; set; }

        [NameInMap("HttpProtocol")]
        [Validation(Required=false)]
        public string HttpProtocol { get; set; }

        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        [NameInMap("PathParameters")]
        [Validation(Required=false)]
        public string PathParameters { get; set; }

        [NameInMap("PostBodyDescription")]
        [Validation(Required=false)]
        public string PostBodyDescription { get; set; }

        [NameInMap("PostBodyType")]
        [Validation(Required=false)]
        public string PostBodyType { get; set; }

        [NameInMap("RequestBody")]
        [Validation(Required=false)]
        public string RequestBody { get; set; }

        [NameInMap("RequestHeaders")]
        [Validation(Required=false)]
        public string RequestHeaders { get; set; }

        [NameInMap("RequestQueries")]
        [Validation(Required=false)]
        public string RequestQueries { get; set; }

        [NameInMap("ResultSample")]
        [Validation(Required=false)]
        public string ResultSample { get; set; }

        [NameInMap("ResultType")]
        [Validation(Required=false)]
        public string ResultType { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("ServiceAddress")]
        [Validation(Required=false)]
        public string ServiceAddress { get; set; }

        [NameInMap("ServiceProtocol")]
        [Validation(Required=false)]
        public string ServiceProtocol { get; set; }

        [NameInMap("ServiceTimeout")]
        [Validation(Required=false)]
        public int? ServiceTimeout { get; set; }

        [NameInMap("SystemParameters")]
        [Validation(Required=false)]
        public string SystemParameters { get; set; }

        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

    }

}
