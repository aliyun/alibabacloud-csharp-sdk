// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeSensitiveSwitchResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("OpenCount")]
        [Validation(Required=false)]
        public long? OpenCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A7F3ED45-5556-5AF3-ADE3-EE48FFF0****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("UserSensitiveDataSwitchList")]
        [Validation(Required=false)]
        public List<DescribeSensitiveSwitchResponseBodyUserSensitiveDataSwitchList> UserSensitiveDataSwitchList { get; set; }
        public class DescribeSensitiveSwitchResponseBodyUserSensitiveDataSwitchList : TeaModel {
            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>id_card</para>
            /// </summary>
            [NameInMap("SensitiveCategory")]
            [Validation(Required=false)]
            public string SensitiveCategory { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>S3</para>
            /// </summary>
            [NameInMap("SensitiveLevel")]
            [Validation(Required=false)]
            public string SensitiveLevel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SwitchStatus")]
            [Validation(Required=false)]
            public int? SwitchStatus { get; set; }

        }

    }

}
