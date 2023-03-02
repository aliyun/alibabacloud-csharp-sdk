// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DeleteDataSourceRequest : TeaModel {
        /// <summary>
        /// The ID of the data source. You can call the [ListDataSources](~~211431~~) operation to obtain the ID.
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public long? DataSourceId { get; set; }

    }

}
