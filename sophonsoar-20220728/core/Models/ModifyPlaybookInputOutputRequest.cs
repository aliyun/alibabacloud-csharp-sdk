// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class ModifyPlaybookInputOutputRequest : TeaModel {
        /// <summary>
        /// The executed mode of a playbook. The value is a JSON array.
        /// </summary>
        [NameInMap("ExeConfig")]
        [Validation(Required=false)]
        public string ExeConfig { get; set; }

        /// <summary>
        /// The configuration of the input parameters. The value is a JSON array.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InputParams")]
        [Validation(Required=false)]
        public string InputParams { get; set; }

        /// <summary>
        /// The language of the content within the request and response.
        /// 
        /// *   **zh**: Chinese (default)
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The configuration of the output parameters. This parameter is unavailable. Leave it empty.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OutputParams")]
        [Validation(Required=false)]
        public string OutputParams { get; set; }

        /// <summary>
        /// The input parameter type.
        /// 
        /// *   **template-ip**
        /// *   **template-file**
        /// *   **template-process**
        /// *   **custom**
        /// </summary>
        [NameInMap("ParamType")]
        [Validation(Required=false)]
        public string ParamType { get; set; }

        /// <summary>
        /// The UUID of the playbook.
        /// 
        /// >  You can call the [DescribePlaybooks](~~DescribePlaybooks~~)operation to query the playbook UUID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PlaybookUuid")]
        [Validation(Required=false)]
        public string PlaybookUuid { get; set; }

    }

}
