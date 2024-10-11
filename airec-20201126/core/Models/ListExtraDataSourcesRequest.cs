// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class ListExtraDataSourcesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>UserCustomDataSource ItemCustomDataSource BehaviorCustomDataSource SampleCustomDataSource</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
