// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class PushItemDataRequest : TeaModel {
        /// <summary>
        /// The enterprise code.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// List of data to be pushed.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public PushItemDataRequestItems Items { get; set; }
        public class PushItemDataRequestItems : TeaModel {
            /// <summary>
            /// API data identification.<props="intl">For details: [GetDataItemList ](https://www.alibabacloud.com/help/en/energy-expert/developer-reference/api-energyexpertexternal-2022-09-23-getdataitemlist)
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// The month.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("month")]
            [Validation(Required=false)]
            public string Month { get; set; }

            /// <summary>
            /// The value of the data item.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public double? Value { get; set; }

        }

        /// <summary>
        /// The year of the data created.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("year")]
        [Validation(Required=false)]
        public string Year { get; set; }

    }

}
