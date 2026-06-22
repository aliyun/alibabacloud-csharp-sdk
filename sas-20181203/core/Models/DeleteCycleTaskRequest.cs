// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteCycleTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the configuration.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeCycleTaskList~~">DescribeCycleTaskList</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>435f626256ebf564cf5ba966a539****</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public string ConfigId { get; set; }

    }

}
