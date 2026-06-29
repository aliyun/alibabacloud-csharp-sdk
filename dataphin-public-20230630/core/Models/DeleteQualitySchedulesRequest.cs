// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class DeleteQualitySchedulesRequest : TeaModel {
        /// <summary>
        /// <para>The delete instruction.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DeleteCommand")]
        [Validation(Required=false)]
        public DeleteQualitySchedulesRequestDeleteCommand DeleteCommand { get; set; }
        public class DeleteQualitySchedulesRequestDeleteCommand : TeaModel {
            /// <summary>
            /// <para>The IDs of the scheduling objects.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("ScheduleIdList")]
            [Validation(Required=false)]
            public List<long?> ScheduleIdList { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

    }

}
