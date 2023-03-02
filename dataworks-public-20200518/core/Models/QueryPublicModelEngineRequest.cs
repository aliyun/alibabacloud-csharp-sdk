// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class QueryPublicModelEngineRequest : TeaModel {
        /// <summary>
        /// The ID of the DataWorks workspace. You can log on to the [DataWorks console](https://account.alibabacloud.com/login/login.htm) and go to the Workspace Management page to view the workspace ID.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// The FML statement that is used to query information about the data modeling engine. For more information, see [Use FML statements to configure and manage data tables](~~298128#task-2091320~~ "After a data table is created, you can execute fast modeling language (FML) statements in the code editor of the table to configure fields and partitions for the table. This topic describes how to use FML statements to configure a data table.").
        /// 
        /// Only SHOW statements are supported.
        /// </summary>
        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

    }

}
