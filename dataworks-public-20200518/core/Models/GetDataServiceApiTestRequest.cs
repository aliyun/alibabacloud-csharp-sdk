// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDataServiceApiTestRequest : TeaModel {
        /// <summary>
        /// <para>The Id of the test. TestDataServiceApi is executed asynchronously after the API is called and the test Id is returned. You can also use ListDataServiceApiTest to obtain the latest test Id.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123434</para>
        /// </summary>
        [NameInMap("TestId")]
        [Validation(Required=false)]
        public long? TestId { get; set; }

    }

}
