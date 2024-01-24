// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsDbRdsNameListResponseBody : TeaModel {
        /// <summary>
        /// Indicates the instances that are used to store the data of a database.
        /// </summary>
        [NameInMap("InstanceNameList")]
        [Validation(Required=false)]
        public DescribeDrdsDbRdsNameListResponseBodyInstanceNameList InstanceNameList { get; set; }
        public class DescribeDrdsDbRdsNameListResponseBodyInstanceNameList : TeaModel {
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public List<string> InstanceName { get; set; }

        }

        /// <summary>
        /// Indicates the ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
