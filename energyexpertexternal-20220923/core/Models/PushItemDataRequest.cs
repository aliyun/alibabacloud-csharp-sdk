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
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// Push data list.
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public PushItemDataRequestItems Items { get; set; }
        public class PushItemDataRequestItems : TeaModel {
            /// <summary>
            /// The data item code.
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// The month.
            /// </summary>
            [NameInMap("month")]
            [Validation(Required=false)]
            public string Month { get; set; }

            /// <summary>
            /// The value of the data item.
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public double? Value { get; set; }

        }

        /// <summary>
        /// The year of the data created.
        /// </summary>
        [NameInMap("year")]
        [Validation(Required=false)]
        public string Year { get; set; }

    }

}
